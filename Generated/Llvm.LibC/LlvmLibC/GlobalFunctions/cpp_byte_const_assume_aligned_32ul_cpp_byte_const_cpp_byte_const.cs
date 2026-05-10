using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14assume_alignedILm32EKNS_3cpp4byteEEEPT0_S5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::byte const* __llvm_libc_20_1_2_::assume_aligned<32ul, __llvm_libc_20_1_2_::cpp::byte const>(__llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class cpp_byte_const_assume_aligned_32ul_cpp_byte_const_cpp_byte_const
{
	public unsafe static void* Invoke(void* ptr)
	{
		llvm_assume.Invoke(parameter: true);
		return ptr;
	}
}
