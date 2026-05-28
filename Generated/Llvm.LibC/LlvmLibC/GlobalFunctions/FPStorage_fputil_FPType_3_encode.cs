using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_3_encode
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE6encodeENS4_11SignificandE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand)")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("value.coerce0")] long Value, [MangledName("value.coerce1")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand")] long Value_coerce1)
	{
		Fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua = default(Fputil_internal_FPRepSem_f94eua);
		Int128 x = default(Int128);
		unchecked
		{
			*(long*)(&fputil_internal_FPRepSem_f94eua) = Value;
			((long*)(&fputil_internal_FPRepSem_f94eua))[1] = Value_coerce1;
			Struct_fiz2nb struct_fiz2nb = TypedInt_unsigned_int128_to_storage_type_b7v9xe.Invoke(&fputil_internal_FPRepSem_f94eua);
			Int128* num = &x;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&x) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 @int = NumericHelper.BitwiseAnd(x, -1L);
			return *(Struct_fiz2nb*)(&@int);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE6encodeENS4_14BiasedExponentE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::BiasedExponent)")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("exp.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::BiasedExponent")] int Exp)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Int128 x = default(Int128);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0 = Exp;
		Struct_fiz2nb struct_fiz2nb = TypedInt_unsigned_int_to_storage_type_e2n647.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
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

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE6encodeENS4_14BiasedExponentENS4_11SignificandE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::BiasedExponent, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand)")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("exp.coerce")] int Exp, [MangledName("sig.coerce0")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::BiasedExponent")] long Sig, [MangledName("sig.coerce1")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand")] long Sig_coerce1)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua = default(Fputil_internal_FPRepSem_f94eua);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Int128 @int = default(Int128);
		Fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(Fputil_internal_FPRepSem_f94eua);
		Int128 y = default(Int128);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0 = Exp;
		unchecked
		{
			*(long*)(&fputil_internal_FPRepSem_f94eua) = Sig;
			((long*)(&fputil_internal_FPRepSem_f94eua))[1] = Sig_coerce1;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, 4L, isVolatile: false);
			Struct_fiz2nb struct_fiz2nb = Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0);
			Int128* num = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 x = @int;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_f94eua2, &fputil_internal_FPRepSem_f94eua, 16L, isVolatile: false);
			Struct_fiz2nb struct_fiz2nb4 = Invoke(*(long*)(&fputil_internal_FPRepSem_f94eua2), ((long*)(&fputil_internal_FPRepSem_f94eua2))[1]);
			Int128* num3 = &y;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			*(long*)num3 = struct_fiz2nb5.field_0;
			byte* num4 = (byte*)(&y) + 8u;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			*(long*)num4 = struct_fiz2nb6.field_1;
			Int128 int2 = NumericHelper.BitwiseOr(x, y);
			return *(Struct_fiz2nb*)(&int2);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE6encodeENS_4SignENS4_14BiasedExponentENS4_11SignificandE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::encode(__llvm_libc_20_1_2_::Sign, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::BiasedExponent, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand)")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("sign.coerce")] sbyte Sign, [MangledName("exp.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] int Exp, [MangledName("sig.coerce0")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::BiasedExponent")] long Sig, [MangledName("sig.coerce1")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand")] long Sig_coerce1)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua = default(Fputil_internal_FPRepSem_f94eua);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(Fputil_internal_FPRepSem_f94eua);
		Int128 @int = default(Int128);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua3 = default(Fputil_internal_FPRepSem_f94eua);
		Int128 int2 = default(Int128);
		anon_izyfb.Val = Sign;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0 = Exp;
		unchecked
		{
			*(long*)(&fputil_internal_FPRepSem_f94eua) = Sig;
			((long*)(&fputil_internal_FPRepSem_f94eua))[1] = Sig_coerce1;
			Int128 int3;
			if (Sign_is_neg.Invoke(&anon_izyfb))
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, 4L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_f94eua2, &fputil_internal_FPRepSem_f94eua, 16L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0, *(long*)(&fputil_internal_FPRepSem_f94eua2), ((long*)(&fputil_internal_FPRepSem_f94eua2))[1]);
				Int128* num = &@int;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num = struct_fiz2nb2.field_0;
				byte* num2 = (byte*)(&@int) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb3.field_1;
				int3 = NumericHelper.BitwiseOr(y: @int, x: 0L);
			}
			else
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, 4L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepSem_f94eua3, &fputil_internal_FPRepSem_f94eua, 16L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb4 = Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0, *(long*)(&fputil_internal_FPRepSem_f94eua3), ((long*)(&fputil_internal_FPRepSem_f94eua3))[1]);
				Int128* num3 = &int2;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				*(long*)num3 = struct_fiz2nb5.field_0;
				byte* num4 = (byte*)(&int2) + 8u;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				*(long*)num4 = struct_fiz2nb6.field_1;
				int3 = int2;
			}
			return *(Struct_fiz2nb*)(&int3);
		}
	}
}
