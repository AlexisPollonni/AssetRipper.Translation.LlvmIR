using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_long_long_false_OptionalStorage
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIxE15OptionalStorageIxLb0EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long long>::OptionalStorage<long long, false>::OptionalStorage()")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		unchecked
		{
			*(sbyte*)(&((Llvm_libc_20_1_2_cpp_expected*)This)->field) = 0;
			((Llvm_libc_20_1_2_cpp_expected*)This)->In_use = 0;
		}
	}
}
