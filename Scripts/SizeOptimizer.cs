#:package LLVMSharp

#:property AllowUnsafeBlocks=true
#:property InvariantGlobalization=true

using System.Runtime.InteropServices;
using LLVMSharp.Interop;

var input = args[0];
var output = args[1];
Run(Path.GetFileName(input), File.ReadAllBytes(input), output);

static unsafe void Run(string name, ReadOnlySpan<byte> content, string outputPath)
{
	fixed (byte* ptr = content)
	{
		var namePtr = Marshal.StringToHGlobalAnsi(name);
		LLVMMemoryBufferRef buffer = LLVM.CreateMemoryBufferWithMemoryRange(
			(sbyte*)ptr,
			(nuint)content.Length,
			(sbyte*)namePtr,
			1
		);
		try
		{
			var context = LLVMContextRef.Create();
			try
			{
				var module = context.ParseIR(buffer);
				OptimizeModule(module, context);
				module.PrintToFile(outputPath);
			}
			finally
			{
				// https://github.com/dotnet/LLVMSharp/issues/234
				//context.Dispose();
			}
		}
		finally
		{
			// This fails randomly with no real explanation.
			// I'm fairly certain that the IR text data is only referenced (not copied),
			// so the memory leak of not disposing the buffer is probably not a big deal.
			// https://github.com/dotnet/LLVMSharp/issues/234
			//LLVM.DisposeMemoryBuffer(buffer);

			Marshal.FreeHGlobal(namePtr);
		}
	}
}

static unsafe void OptimizeModule(LLVMModuleRef module, LLVMContextRef context)
{
	// https://github.com/llvm/llvm-project/blob/a8d0ae3412bdbbf3248192c31f94f6649a217b3a/llvm/include/llvm/IR/Attributes.td
	ReadOnlySpan<uint> attributesToAdd =
	[
		GetEnumAttributeKindForName("optsize"u8),
		GetEnumAttributeKindForName("minsize"u8),
	];
	ReadOnlySpan<uint> attributesToRemove =
	[
		GetEnumAttributeKindForName("optnone"u8),
		GetEnumAttributeKindForName("alwaysinline"u8),
	];

	foreach (var function in module.GetFunctions())
	{
		function.Linkage = LLVMLinkage.LLVMExternalLinkage;

		foreach (var attribute in attributesToRemove)
		{
			LLVM.RemoveEnumAttributeAtIndex(
				function,
				LLVMAttributeIndex.LLVMAttributeFunctionIndex,
				attribute
			);
		}
		foreach (var attribute in attributesToAdd)
		{
			if (
				LLVM.GetEnumAttributeAtIndex(
					function,
					LLVMAttributeIndex.LLVMAttributeFunctionIndex,
					attribute
				) == null
			)
			{
				function.AddAttributeAtIndex(
					LLVMAttributeIndex.LLVMAttributeFunctionIndex,
					LLVM.CreateEnumAttribute(context, attribute, default)
				);
			}
		}

		DisableTailCalls(function, context);

		foreach (var basicBlock in function.GetBasicBlocks())
		{
			basicBlock.AsValue().Name = ""; // Clear basic block names to reduce size
		}

		foreach (var instruction in function.GetInstructions())
		{
			instruction.Name = ""; // Clear instruction names to reduce size
			if (
				instruction.InstructionOpcode
				is LLVMOpcode.LLVMCall
					or LLVMOpcode.LLVMInvoke
					or LLVMOpcode.LLVMCallBr
			)
			{
				instruction.TailCallKind = LLVMTailCallKind.LLVMTailCallKindNone;
			}
		}
	}

	foreach (var global in module.GetGlobals())
	{
		global.Linkage = LLVMLinkage.LLVMExternalLinkage;
	}
}

static unsafe void DisableTailCalls(LLVMValueRef function, LLVMContextRef context)
{
	var disableTailCallsString = MemoryMarshal.Cast<byte, sbyte>("disable-tail-calls"u8);
	var trueString = MemoryMarshal.Cast<byte, sbyte>("true"u8);

	var disableTailCallsLength = (uint)disableTailCallsString.Length;
	var trueLength = (uint)trueString.Length;

	fixed (sbyte* disableTailCallsPtr = disableTailCallsString)
	{
		fixed (sbyte* truePtr = trueString)
		{
			LLVMAttributeRef attribute = LLVM.GetStringAttributeAtIndex(
				function,
				LLVMAttributeIndex.LLVMAttributeFunctionIndex,
				disableTailCallsPtr,
				disableTailCallsLength
			);
			bool needToRemoveAttribute;
			if (attribute != null)
			{
				uint valueLength = 0;
				var valuePtr = LLVM.GetStringAttributeValue(attribute, &valueLength);
				if (valuePtr == null)
				{
					needToRemoveAttribute = true;
				}
				else
				{
					needToRemoveAttribute = !new ReadOnlySpan<sbyte>(
						valuePtr,
						(int)valueLength
					).SequenceEqual(trueString);
				}
			}
			else
			{
				needToRemoveAttribute = false;
			}

			var needToAddAttribute = attribute == null || needToRemoveAttribute;

			if (needToRemoveAttribute)
			{
				LLVM.RemoveStringAttributeAtIndex(
					function,
					LLVMAttributeIndex.LLVMAttributeFunctionIndex,
					disableTailCallsPtr,
					disableTailCallsLength
				);
			}

			if (needToAddAttribute)
			{
				attribute = LLVM.CreateStringAttribute(
					context,
					disableTailCallsPtr,
					disableTailCallsLength,
					truePtr,
					trueLength
				);
				function.AddAttributeAtIndex(
					LLVMAttributeIndex.LLVMAttributeFunctionIndex,
					attribute
				);
			}
		}
	}
}

static unsafe uint GetEnumAttributeKindForName(ReadOnlySpan<byte> utf8String)
{
	fixed (byte* ptr = utf8String)
	{
		var namePtr = (nint)ptr;
		return LLVM.GetEnumAttributeKindForName((sbyte*)namePtr, (nuint)utf8String.Length);
	}
}

static class LlvmSharpExtensions
{
	public static unsafe IEnumerable<LLVMValueRef> GetFunctions(this LLVMModuleRef module)
	{
		var function = module.FirstFunction;
		while (function.Handle != 0)
		{
			yield return function;
			function = function.NextFunction;
		}
	}

	public static unsafe IEnumerable<LLVMValueRef> GetGlobals(this LLVMModuleRef module)
	{
		var global = module.FirstGlobal;
		while (global.Handle != 0)
		{
			yield return global;
			global = global.NextGlobal;
		}
	}

	public static unsafe IEnumerable<LLVMValueRef> GetInstructions(
		this LLVMBasicBlockRef basicBlock
	)
	{
		var instruction = basicBlock.FirstInstruction;
		while (instruction.Handle != 0)
		{
			yield return instruction;
			instruction = instruction.NextInstruction;
		}
	}

	public static unsafe IEnumerable<LLVMValueRef> GetInstructions(this LLVMValueRef value)
	{
		if (value.IsAFunction != default)
		{
			return GetFunctionInstructions(value);
		}
		else if (value.IsABasicBlock != default)
		{
			return value.AsBasicBlock().GetInstructions();
		}
		else if (value.IsAInstruction != default)
		{
			return [value];
		}
		else
		{
			return [];
		}

		static IEnumerable<LLVMValueRef> GetFunctionInstructions(LLVMValueRef function)
		{
			foreach (var basicBlock in function.GetBasicBlocks())
			{
				foreach (var instruction in basicBlock.GetInstructions())
				{
					yield return instruction;
				}
			}
		}
	}
}
