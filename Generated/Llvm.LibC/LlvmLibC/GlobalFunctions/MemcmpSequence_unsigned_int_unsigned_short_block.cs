using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class MemcmpSequence_unsigned_int_unsigned_short_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic14MemcmpSequenceIjJtEE5blockEPKNS_3cpp4byteES6_")]
	[DemangledName("__llvm_libc_20_1_2_::generic::MemcmpSequence<unsigned int, unsigned short>::block(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*)")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p1, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p2)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		unchecked
		{
			*(int*)(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2) = -1431655766;
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_cmp_unsigned_int.Invoke(p1, p2, 0L);
			if (!StrictIntegralType_int_ToBoolean.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2))
			{
				fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = MemcmpSequence_unsigned_short_block.Invoke((byte*)p1 + 4, (byte*)p2 + 4);
			}
			return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
		}
	}
}
