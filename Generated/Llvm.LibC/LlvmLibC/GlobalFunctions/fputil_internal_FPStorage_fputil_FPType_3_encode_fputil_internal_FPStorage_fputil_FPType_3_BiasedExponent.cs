using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE6encodeENS4_14BiasedExponentE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::BiasedExponent)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_3_encode_fputil_internal_FPStorage_fputil_FPType_3_BiasedExponent
{
	public unsafe static Struct_fiz2nb Invoke([MangledName("exp.coerce")] int exp)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Int128 x = default(Int128);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = exp;
		Struct_fiz2nb struct_fiz2nb = fputil_internal_FPStorage_fputil_FPType_3_TypedInt_unsigned_int_to_storage_type_const.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2);
		Int128* num = &x;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&x) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 @int = NumericHelper.BitwiseAnd(NumericHelper.ShiftLeft(x, 112L), 0L);
			return *(Struct_fiz2nb*)(&@int);
		}
	}
}
