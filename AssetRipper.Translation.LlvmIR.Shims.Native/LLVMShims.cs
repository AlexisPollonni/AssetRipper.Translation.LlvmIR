using LLVMSharp.Interop;
using System.Text;
using static AssetRipper.Translation.LlvmIR.Shims.Native.LibLlvmSharp;

namespace AssetRipper.Translation.LlvmIR.Shims.Native;

public static unsafe class LLVMShims
{
	private static int ValueGetDemangledName(LLVMOpaqueValue* value, Span<byte> buffer)
	{
		fixed (byte* bufferPtr = buffer)
		{
			return Value_getDemangledName(value, (sbyte*)bufferPtr, buffer.Length);
		}
	}

	public static LLVMTypeRef FunctionGetReturnType(LLVMValueRef fn)
	{
		return Function_getReturnType(fn);
	}

	public static LLVMTypeRef FunctionGetFunctionType(LLVMValueRef fn)
	{
		return Function_getFunctionType(fn);
	}

	public static ReadOnlySpan<byte> ConstantDataArrayGetData(LLVMValueRef constantDataArray)
	{
		int size;
		var data = ConstantDataArray_getData(constantDataArray, &size);
		return new(data, size);
	}

	public static string? ValueGetDemangledName(LLVMValueRef value)
	{
		const int MaxLength = 4096;
		Span<byte> buffer = stackalloc byte[MaxLength];
		var length = ValueGetDemangledName(value, buffer);
		return length == 0 ? null : Encoding.UTF8.GetString(buffer[..length]);
	}

	public static bool InstructionHasNoSignedWrap(LLVMValueRef instruction)
	{
		return Instruction_hasNoSignedWrap(instruction) == 1;
	}

	public static bool InstructionHasNoUnsignedWrap(LLVMValueRef instruction)
	{
		return Instruction_hasNoUnsignedWrap(instruction) == 1;
	}
}
