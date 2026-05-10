using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14assume_alignedILm32ENS_3cpp4byteEEEPT0_S4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::byte* __llvm_libc_20_1_2_::assume_aligned<32ul, __llvm_libc_20_1_2_::cpp::byte>(__llvm_libc_20_1_2_::cpp::byte*)")]
internal static partial class cpp_byte_assume_aligned_32ul_cpp_byte_cpp_byte
{
	public unsafe static void* Invoke(void* ptr)
	{
		llvm_assume.Invoke(parameter: true);
		return ptr;
	}
}
