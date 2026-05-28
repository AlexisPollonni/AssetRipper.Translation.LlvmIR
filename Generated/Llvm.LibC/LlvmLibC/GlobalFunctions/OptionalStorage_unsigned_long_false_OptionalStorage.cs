using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_unsigned_long_false_OptionalStorage
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalImE15OptionalStorageImLb0EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned long>::OptionalStorage<unsigned long, false>::OptionalStorage()")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		unchecked
		{
			*(sbyte*)(&((Cpp_expected*)This)->field) = 0;
			((Cpp_expected*)This)->In_use = 0;
		}
	}
}
