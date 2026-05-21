using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcmp_unsigned_int_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemcmpIjE4tailEPKNS_3cpp4byteES6_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memcmp<unsigned int>::tail(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p1, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p2, [NativeType("unsigned long")] long count)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = new fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt
		{
			field_0 = Memcmp_unsigned_int_block_offset.Invoke(p1, p2, unchecked(count - 4L))
		};
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
