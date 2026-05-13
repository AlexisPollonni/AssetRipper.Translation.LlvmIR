using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_22align_to_next_boundaryILm32ENS_3cpp4byteEEEvRPT0_Rm")]
[DemangledName("void __llvm_libc_20_1_2_::align_to_next_boundary<32ul, __llvm_libc_20_1_2_::cpp::byte>(__llvm_libc_20_1_2_::cpp::byte*&, unsigned long&)")]
internal static partial class void_align_to_next_boundary_32ul_cpp_byte_cpp_byte_unsigned_long
{
	public unsafe static void Invoke(void* p1, void* count)
	{
		void* ptr = null;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = *unchecked((void**)p1);
		void_align_p1_to_next_boundary_32ul_cpp_byte_cpp_byte_const_cpp_byte_restrict_cpp_byte_const_restrict_unsigned_long.Invoke(p1, &ptr, count);
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
	}
}
