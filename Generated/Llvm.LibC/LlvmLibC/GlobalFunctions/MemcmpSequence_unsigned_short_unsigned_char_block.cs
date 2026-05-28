using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class MemcmpSequence_unsigned_short_unsigned_char_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic14MemcmpSequenceItJhEE5blockEPKNS_3cpp4byteES6_")]
	[DemangledName("__llvm_libc_20_1_2_::generic::MemcmpSequence<unsigned short, unsigned char>::block(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*)")]
	public unsafe static int Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		unchecked
		{
			*(int*)(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt) = -1431655766;
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Generic_cmp_unsigned_short.Invoke(P1, P2, 0L);
			if (!StrictIntegralType_int_ToBoolean.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt))
			{
				fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = MemcmpSequence_unsigned_char_block.Invoke((byte*)P1 + 2, (byte*)P2 + 2);
			}
			return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0;
		}
	}
}
