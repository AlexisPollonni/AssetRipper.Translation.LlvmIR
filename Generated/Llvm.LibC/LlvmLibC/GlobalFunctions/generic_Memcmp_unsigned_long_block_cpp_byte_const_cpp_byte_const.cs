using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemcmpImE5blockEPKNS_3cpp4byteES6_")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memcmp<unsigned long>::block(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class generic_Memcmp_unsigned_long_block_cpp_byte_const_cpp_byte_const
{
	public unsafe static int Invoke(void* p1, void* p2)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = new fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt
		{
			field_0 = generic_Memcmp_unsigned_long_block_offset_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, 0L)
		};
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
