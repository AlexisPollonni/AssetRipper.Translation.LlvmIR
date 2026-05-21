using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_assume_aligned_32ul_cpp_byte
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14assume_alignedILm32ENS_3cpp4byteEEEPT0_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::byte* __llvm_libc_20_1_2_::assume_aligned<32ul, __llvm_libc_20_1_2_::cpp::byte>(__llvm_libc_20_1_2_::cpp::byte*)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::byte*")]
	public unsafe static void* Invoke([MangledName("ptr")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Ptr)
	{
		Llvm_assume.Invoke(parameter: true);
		return Ptr;
	}
}
