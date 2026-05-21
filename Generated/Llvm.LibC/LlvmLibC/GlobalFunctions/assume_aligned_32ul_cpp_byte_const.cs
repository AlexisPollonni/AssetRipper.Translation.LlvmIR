using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class assume_aligned_32ul_cpp_byte_const
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14assume_alignedILm32EKNS_3cpp4byteEEEPT0_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::byte const* __llvm_libc_20_1_2_::assume_aligned<32ul, __llvm_libc_20_1_2_::cpp::byte const>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::byte const*")]
	public unsafe static void* Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* ptr)
	{
		llvm_assume.Invoke(parameter: true);
		return ptr;
	}
}
