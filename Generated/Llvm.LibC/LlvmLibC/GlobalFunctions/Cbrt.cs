using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cbrt
{
	[MangledName("cbrt")]
	[DemangledName("cbrt")]
	public unsafe static double Invoke([MangledName("x")] double X)
	{
		long num = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		int num2 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm4 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm5 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm6 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		int num3 = 0;
		int field_ = 0;
		int num4 = 0;
		double x = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm7 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		long num5 = 0L;
		double num6 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm8 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double num7 = 0.0;
		InlineArray3_Double inlineArray3_Double = default(InlineArray3_Double);
		double num8 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		double num9 = 0.0;
		double num10 = 0.0;
		InlineArray3_Double inlineArray3_Double2 = default(InlineArray3_Double);
		double num11 = 0.0;
		double num12 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair4 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair5 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		double num13 = 0.0;
		double num14 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm9 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double x2 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm10 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm11 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double num15 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair6 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair7 = default(Llvm_libc_20_1_2_NumberPair);
		double num16 = 0.0;
		double b = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair8 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair9 = default(Llvm_libc_20_1_2_NumberPair);
		double num17 = 0.0;
		double num18 = 0.0;
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd11 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd12 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		double num19 = 0.0;
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd13 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd14 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd15 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd16 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd18 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh2 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		double r = 0.0;
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh3 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh4 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Int128 int5 = default(Int128);
		Int128 int6 = default(Int128);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh5 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Int128 int7 = default(Int128);
		Int128 int8 = default(Int128);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh6 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh7 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Int128 int9 = default(Int128);
		Int128 int10 = default(Int128);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd19 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh8 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Int128 int11 = default(Int128);
		Int128 int12 = default(Int128);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd21 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd22 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		double num20 = X;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
		FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, num20);
		double result;
		unchecked
		{
			long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2));
			llvm_libc_20_1_2_fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val;
			long num21 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			num = num21;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = 682;
			long num22 = num;
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
			long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_normal.Invoke(anon_izyfb.Val);
			llvm_libc_20_1_2_fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val2;
			bool num23 = (ulong)num22 < (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3));
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
			int value;
			if (num23)
			{
				value = 1;
			}
			else
			{
				long num24 = num;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb2.Val);
				llvm_libc_20_1_2_fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val = val3;
				value = (((ulong)num24 >= (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4))) ? 1 : 0);
			}
			bool num25 = Details_expects_bool_condition_bool.Invoke((byte)value != 0, Expected: false);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
			if (num25)
			{
				bool num26 = num20 == 0.0;
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
				int num27;
				if (num26)
				{
					num27 = 1;
				}
				else
				{
					long num28 = num;
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb3.Val);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.Val = val4;
					num27 = (((ulong)num28 >= (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5))) ? 1 : 0);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
				if (num27 != 0)
				{
					result = num20 + num20;
					goto IL_19f0;
				}
				num20 *= 1.152921504606847E+18;
				num2 -= 20;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6, num20);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6));
			Llvm_lifetime_start_p0.Invoke(4L, &field_);
			field_ = (int)((uint)num3 / 3u) + num2;
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = (int)((uint)num3 % 3u);
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
			FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6)) | 0x3FF0000000000000L);
			double num29 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
			x = num29;
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6)) & -9218868437227405313L;
			num5 |= (long)((ulong)(uint)(num4 + 1023) << 52);
			Llvm_lifetime_start_p0.Invoke(8L, &num6);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
			FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm8, num5);
			double num30 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
			num6 = num30;
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = Anonymous_namespace_intial_approximation.Invoke(x);
			Llvm_lifetime_start_p0.Invoke(24L, &inlineArray3_Double);
			*(double*)(&inlineArray3_Double) = 1.0;
			((double*)(&inlineArray3_Double))[1] = 0.6299605249474366;
			((double*)(&inlineArray3_Double))[2L] = 0.3968502629920499;
			Llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = Unsafe.As<InlineArray3_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray3_Double, (nint)(uint)num4 * (nint)sizeof(double))) * num7;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_exact_mult_27ul.Invoke(num6, num6);
			Llvm_libc_20_1_2_NumberPair* num31 = &llvm_libc_20_1_2_NumberPair;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num31 = struct_4ydhja2.field_0;
			byte* num32 = (byte*)(&llvm_libc_20_1_2_NumberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num32 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Fputil_exact_mult_27ul.Invoke(num8, num8);
			Llvm_libc_20_1_2_NumberPair* num33 = &llvm_libc_20_1_2_NumberPair2;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num33 = struct_4ydhja5.field_0;
			byte* num34 = (byte*)(&llvm_libc_20_1_2_NumberPair2) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num34 = struct_4ydhja6.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			*(double*)(&llvm_libc_20_1_2_NumberPair3) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = Fputil_quick_mult.Invoke(num8, &llvm_libc_20_1_2_NumberPair2);
			Llvm_libc_20_1_2_NumberPair* num35 = &llvm_libc_20_1_2_NumberPair3;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num35 = struct_4ydhja8.field_0;
			byte* num36 = (byte*)(&llvm_libc_20_1_2_NumberPair3) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num36 = struct_4ydhja9.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = Anonymous_namespace_get_error.Invoke(&llvm_libc_20_1_2_NumberPair3, &llvm_libc_20_1_2_NumberPair);
			Llvm_lifetime_start_p0.Invoke(8L, &num10);
			num10 = 4.440892098500626E-16;
			Llvm_lifetime_start_p0.Invoke(24L, &inlineArray3_Double2);
			*(double*)(&inlineArray3_Double2) = -0.33333333333333376;
			((double*)(&inlineArray3_Double2))[1] = 2.0 / 9.0;
			((double*)(&inlineArray3_Double2))[2L] = -14.0 / 81.0;
			Llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = Fputil_polyeval_double_double_double.Invoke(num9, *(double*)(&inlineArray3_Double2), Unsafe.As<InlineArray3_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray3_Double2, sizeof(double))), Unsafe.As<InlineArray3_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray3_Double2, (nint)2 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = num8 * num9;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			*(double*)(&llvm_libc_20_1_2_NumberPair4) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair4))[1] = double.NaN;
			llvm_libc_20_1_2_NumberPair4.Lo = num12 * num11;
			llvm_libc_20_1_2_NumberPair4.Hi = num8;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair5);
			*(double*)(&llvm_libc_20_1_2_NumberPair5) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair5))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja10 = Fputil_quick_mult.Invoke(num6, &llvm_libc_20_1_2_NumberPair4);
			Llvm_libc_20_1_2_NumberPair* num37 = &llvm_libc_20_1_2_NumberPair5;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num37 = struct_4ydhja11.field_0;
			byte* num38 = (byte*)(&llvm_libc_20_1_2_NumberPair5) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num38 = struct_4ydhja12.field_1;
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
			*(int*)(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt) = -1431655766;
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = field_;
			Llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = llvm_libc_20_1_2_NumberPair5.Hi + llvm_libc_20_1_2_NumberPair5.Lo;
			Llvm_lifetime_start_p0.Invoke(8L, &num14);
			num14 = llvm_libc_20_1_2_NumberPair5.Hi + Fputil_multiply_add_double.Invoke(num12, 8.881784197001252E-16 * num6, llvm_libc_20_1_2_NumberPair5.Lo);
			if (Details_expects_bool_condition_bool.Invoke(num14 == num13, Expected: true))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm9, num13);
				bool num39 = Details_expects_bool_condition_bool.Invoke((FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm9)) & 0x7FFFFFFFFL) == 0L, Expected: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
				if (num39)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &x2);
					x2 = num13 - llvm_libc_20_1_2_NumberPair5.Hi - llvm_libc_20_1_2_NumberPair5.Lo;
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm10);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm11);
					FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm11, x2);
					long val5 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm11));
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm10.FPRepImpl.FPRepSem.FPStorage.Val = val5;
					bool num40 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm10) < 5.902958103587057E+20;
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm11);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm10);
					if (num40)
					{
						Fputil_clear_except_if_required.Invoke(32);
					}
					Llvm_lifetime_end_p0.Invoke(8L, &x2);
				}
				result = _0_Invoke_kh9pxq.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, num13);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num15);
				num15 = Llvm_fmuladd_f64.Invoke(parameter_2: llvm_libc_20_1_2_NumberPair4.Hi, parameter_0: num11 + 4.440892098500626E-16, parameter_1: num12);
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair6);
				*(double*)(&llvm_libc_20_1_2_NumberPair6) = double.NaN;
				((double*)(&llvm_libc_20_1_2_NumberPair6))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja13 = Fputil_exact_mult_27ul.Invoke(num15, num15);
				Llvm_libc_20_1_2_NumberPair* num41 = &llvm_libc_20_1_2_NumberPair6;
				Struct_4ydhja struct_4ydhja14 = struct_4ydhja13;
				*(double*)num41 = struct_4ydhja14.field_0;
				byte* num42 = (byte*)(&llvm_libc_20_1_2_NumberPair6) + 8u;
				Struct_4ydhja struct_4ydhja15 = struct_4ydhja13;
				*(double*)num42 = struct_4ydhja15.field_1;
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair7);
				*(double*)(&llvm_libc_20_1_2_NumberPair7) = double.NaN;
				((double*)(&llvm_libc_20_1_2_NumberPair7))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja16 = Fputil_quick_mult.Invoke(num15, &llvm_libc_20_1_2_NumberPair6);
				Llvm_libc_20_1_2_NumberPair* num43 = &llvm_libc_20_1_2_NumberPair7;
				Struct_4ydhja struct_4ydhja17 = struct_4ydhja16;
				*(double*)num43 = struct_4ydhja17.field_0;
				byte* num44 = (byte*)(&llvm_libc_20_1_2_NumberPair7) + 8u;
				Struct_4ydhja struct_4ydhja18 = struct_4ydhja16;
				*(double*)num44 = struct_4ydhja18.field_1;
				Llvm_lifetime_start_p0.Invoke(8L, &num16);
				num16 = Anonymous_namespace_get_error.Invoke(&llvm_libc_20_1_2_NumberPair7, &llvm_libc_20_1_2_NumberPair);
				Llvm_lifetime_start_p0.Invoke(8L, &b);
				b = num16 * (num15 * (-1.0 / 3.0));
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair8);
				*(double*)(&llvm_libc_20_1_2_NumberPair8) = double.NaN;
				((double*)(&llvm_libc_20_1_2_NumberPair8))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja19 = Fputil_exact_add_true.Invoke(num15, b);
				Llvm_libc_20_1_2_NumberPair* num45 = &llvm_libc_20_1_2_NumberPair8;
				Struct_4ydhja struct_4ydhja20 = struct_4ydhja19;
				*(double*)num45 = struct_4ydhja20.field_0;
				byte* num46 = (byte*)(&llvm_libc_20_1_2_NumberPair8) + 8u;
				Struct_4ydhja struct_4ydhja21 = struct_4ydhja19;
				*(double*)num46 = struct_4ydhja21.field_1;
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair9);
				*(double*)(&llvm_libc_20_1_2_NumberPair9) = double.NaN;
				((double*)(&llvm_libc_20_1_2_NumberPair9))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja22 = Fputil_quick_mult.Invoke(num6, &llvm_libc_20_1_2_NumberPair8);
				Llvm_libc_20_1_2_NumberPair* num47 = &llvm_libc_20_1_2_NumberPair9;
				Struct_4ydhja struct_4ydhja23 = struct_4ydhja22;
				*(double*)num47 = struct_4ydhja23.field_0;
				byte* num48 = (byte*)(&llvm_libc_20_1_2_NumberPair9) + 8u;
				Struct_4ydhja struct_4ydhja24 = struct_4ydhja22;
				*(double*)num48 = struct_4ydhja24.field_1;
				Llvm_lifetime_start_p0.Invoke(8L, &num17);
				num17 = llvm_libc_20_1_2_NumberPair9.Hi + Fputil_multiply_add_double.Invoke(num6, 1.9721522630525295E-31, llvm_libc_20_1_2_NumberPair9.Lo);
				Llvm_lifetime_start_p0.Invoke(8L, &num18);
				num18 = llvm_libc_20_1_2_NumberPair9.Hi + Fputil_multiply_add_double.Invoke(num6, -1.9721522630525295E-31, llvm_libc_20_1_2_NumberPair9.Lo);
				if (Details_expects_bool_condition_bool.Invoke(num17 == num18, Expected: true))
				{
					result = _0_Invoke_kh9pxq.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, num17);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
					*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) = -86;
					sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 1;
					*ptr = -86;
					ptr[1] = -86;
					ptr[2] = -86;
					((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd))[1] = -1431655766;
					sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 8;
					*(long*)ptr2 = -6148914691236517206L;
					((long*)ptr2)[1] = -6148914691236517206L;
					DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2, llvm_libc_20_1_2_NumberPair8.Hi);
					DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3, llvm_libc_20_1_2_NumberPair8.Lo);
					Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3);
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
					*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4) = -86;
					sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4) + 1;
					*ptr3 = -86;
					ptr3[1] = -86;
					ptr3[2] = -86;
					((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4))[1] = -1431655766;
					sbyte* ptr4 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4) + 8;
					*(long*)ptr4 = -6148914691236517206L;
					((long*)ptr4)[1] = -6148914691236517206L;
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5);
					Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
					Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5);
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6);
					*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6) = -86;
					sbyte* ptr5 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6) + 1;
					*ptr5 = -86;
					ptr5[1] = -86;
					ptr5[2] = -86;
					((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6))[1] = -1431655766;
					sbyte* ptr6 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6) + 8;
					*(long*)ptr6 = -6148914691236517206L;
					((long*)ptr6)[1] = -6148914691236517206L;
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7);
					DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, num6);
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8);
					DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8, num6);
					Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7);
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9);
					*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9) = -86;
					sbyte* ptr7 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9) + 1;
					*ptr7 = -86;
					ptr7[1] = -86;
					ptr7[2] = -86;
					((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9))[1] = -1431655766;
					sbyte* ptr8 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9) + 8;
					*(long*)ptr8 = -6148914691236517206L;
					((long*)ptr8)[1] = -6148914691236517206L;
					Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6);
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10);
					*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10) = -86;
					sbyte* ptr9 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10) + 1;
					*ptr9 = -86;
					ptr9[1] = -86;
					ptr9[2] = -86;
					((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10))[1] = -1431655766;
					sbyte* ptr10 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10) + 8;
					*(long*)ptr10 = -6148914691236517206L;
					((long*)ptr10)[1] = -6148914691236517206L;
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd11, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9, 24L, isVolatile: false);
					DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd12, -1.0);
					Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd11, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd12);
					Llvm_lifetime_start_p0.Invoke(8L, &num19);
					num19 = DyadicFloat_128ul_Double_double_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10);
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd13);
					*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd13) = -86;
					sbyte* ptr11 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd13) + 1;
					*ptr11 = -86;
					ptr11[1] = -86;
					ptr11[2] = -86;
					((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd13))[1] = -1431655766;
					sbyte* ptr12 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd13) + 8;
					*(long*)ptr12 = -6148914691236517206L;
					((long*)ptr12)[1] = -6148914691236517206L;
					DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd14, 1.0);
					DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd15, num19 * (-1.0 / 3.0));
					Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd13, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd14, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd15);
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd16);
					*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd16) = -86;
					sbyte* ptr13 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd16) + 1;
					*ptr13 = -86;
					ptr13[1] = -86;
					ptr13[2] = -86;
					((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd16))[1] = -1431655766;
					sbyte* ptr14 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd16) + 8;
					*(long*)ptr14 = -6148914691236517206L;
					((long*)ptr14)[1] = -6148914691236517206L;
					Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd16, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd13);
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17);
					*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17) = -86;
					sbyte* ptr15 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17) + 1;
					*ptr15 = -86;
					ptr15[1] = -86;
					ptr15[2] = -86;
					((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17))[1] = -1431655766;
					sbyte* ptr16 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17) + 8;
					*(long*)ptr16 = -6148914691236517206L;
					((long*)ptr16)[1] = -6148914691236517206L;
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd18);
					DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd18, num6);
					Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd18, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd16);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd18);
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
					sbyte* ptr17 = (sbyte*)(&llvm_libc_20_1_2_BigInt_qdkjbh);
					*(long*)ptr17 = -6148914691236517206L;
					((long*)ptr17)[1] = -6148914691236517206L;
					ref Llvm_libc_20_1_2_BigInt_qdkjbh mantissa = ref llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17.Mantissa;
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh2);
					Struct_fiz2nb struct_fiz2nb = Llvm_libc_20_1_2_U128.Invoke(Str_59.Pointer);
					Int128* num49 = &@int;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num49 = struct_fiz2nb2.field_0;
					byte* num50 = (byte*)(&@int) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num50 = struct_fiz2nb3.field_1;
					int2 = @int;
					BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2), *(long*)(&int2), ((long*)(&int2))[1]);
					Struct_fiz2nb struct_fiz2nb4 = Llvm_libc_20_1_2_BitwiseAnd.Invoke((Anon_izyfb7*)Unsafe.AsPointer(ref mantissa), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2));
					InlineArray2_Int64* ptr18 = &llvm_libc_20_1_2_BigInt_qdkjbh.Val.Data;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr18)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr18)->field_1 = struct_fiz2nb6.field_1;
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh2);
					Llvm_lifetime_start_p0.Invoke(8L, &r);
					r = DyadicFloat_128ul_Double_double_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17);
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh3);
					Struct_fiz2nb struct_fiz2nb7 = Llvm_libc_20_1_2_U128.Invoke(Str_1.Pointer);
					Int128* num51 = &int3;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					*(long*)num51 = struct_fiz2nb8.field_0;
					byte* num52 = (byte*)(&int3) + 8u;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					*(long*)num52 = struct_fiz2nb9.field_1;
					int4 = int3;
					BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh3), *(long*)(&int4), ((long*)(&int4))[1]);
					bool num53 = Llvm_libc_20_1_2_LessThan.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh3));
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh4);
					int num54;
					if (num53)
					{
						num54 = 1;
					}
					else
					{
						Struct_fiz2nb struct_fiz2nb10 = Llvm_libc_20_1_2_U128.Invoke(Str_2.Pointer);
						Int128* num55 = &int5;
						Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
						*(long*)num55 = struct_fiz2nb11.field_0;
						byte* num56 = (byte*)(&int5) + 8u;
						Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
						*(long*)num56 = struct_fiz2nb12.field_1;
						int6 = int5;
						BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh4), *(long*)(&int6), ((long*)(&int6))[1]);
						num54 = (Llvm_libc_20_1_2_GreaterThanOrEquals_crwxpm.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh4)) ? 1 : 0);
					}
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh4);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh3);
					if (num54 != 0)
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh5);
						Struct_fiz2nb struct_fiz2nb13 = Llvm_libc_20_1_2_U128.Invoke(Str_3.Pointer);
						Int128* num57 = &int7;
						Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
						*(long*)num57 = struct_fiz2nb14.field_0;
						byte* num58 = (byte*)(&int7) + 8u;
						Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
						*(long*)num58 = struct_fiz2nb15.field_1;
						int8 = int7;
						BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh5), *(long*)(&int8), ((long*)(&int8))[1]);
						Struct_fiz2nb struct_fiz2nb16 = Llvm_libc_20_1_2_Operator_2rywi9.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17.Mantissa), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh5));
						InlineArray2_Int64* ptr19 = &llvm_libc_20_1_2_BigInt_qdkjbh6.Val.Data;
						Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
						((Struct_fiz2nb*)ptr19)->field_0 = struct_fiz2nb17.field_0;
						Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
						((Struct_fiz2nb*)ptr19)->field_1 = struct_fiz2nb18.field_1;
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh5);
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh7);
						Struct_fiz2nb struct_fiz2nb19 = Llvm_libc_20_1_2_U128.Invoke(Str_2.Pointer);
						Int128* num59 = &int9;
						Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
						*(long*)num59 = struct_fiz2nb20.field_0;
						byte* num60 = (byte*)(&int9) + 8u;
						Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
						*(long*)num60 = struct_fiz2nb21.field_1;
						int10 = int9;
						BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh7), *(long*)(&int10), ((long*)(&int10))[1]);
						bool num61 = Llvm_libc_20_1_2_GreaterThanOrEquals_crwxpm.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh7));
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh7);
						if (num61)
						{
							Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd19);
							*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd19) = -86;
							sbyte* ptr20 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd19) + 1;
							*ptr20 = -86;
							ptr20[1] = -86;
							ptr20[2] = -86;
							((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd19))[1] = -1431655766;
							sbyte* ptr21 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd19) + 8;
							*(long*)ptr21 = -6148914691236517206L;
							((long*)ptr21)[1] = -6148914691236517206L;
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17.Sign, 1L, isVolatile: false);
							int e = checked(llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17.Exponent - 123);
							Struct_fiz2nb struct_fiz2nb22 = Llvm_libc_20_1_2_U128.Invoke(Str_4.Pointer);
							Int128* num62 = &int11;
							Struct_fiz2nb struct_fiz2nb23 = struct_fiz2nb22;
							*(long*)num62 = struct_fiz2nb23.field_0;
							byte* num63 = (byte*)(&int11) + 8u;
							Struct_fiz2nb struct_fiz2nb24 = struct_fiz2nb22;
							*(long*)num63 = struct_fiz2nb24.field_1;
							int12 = int11;
							BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh8), *(long*)(&int12), ((long*)(&int12))[1]);
							DyadicFloat_128ul_Constructor.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd19, anon_izyfb4.Val, e, *(long*)(&llvm_libc_20_1_2_BigInt_qdkjbh8), ((long*)(&llvm_libc_20_1_2_BigInt_qdkjbh8))[1]);
							Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20);
							*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20) = -86;
							sbyte* ptr22 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20) + 1;
							*ptr22 = -86;
							ptr22[1] = -86;
							ptr22[2] = -86;
							((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20))[1] = -1431655766;
							sbyte* ptr23 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20) + 8;
							*(long*)ptr23 = -6148914691236517206L;
							((long*)ptr23)[1] = -6148914691236517206L;
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd21, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17, 24L, isVolatile: false);
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd22, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd19, 24L, isVolatile: false);
							Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd21, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd22);
							r = DyadicFloat_128ul_Double_double_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20);
							Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20);
							Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd19);
						}
						else
						{
							r = DyadicFloat_128ul_Double_double_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17);
						}
						Fputil_clear_except_if_required.Invoke(32);
					}
					result = _0_Invoke_kh9pxq.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, r);
					Llvm_lifetime_end_p0.Invoke(8L, &r);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd16);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd13);
					Llvm_lifetime_end_p0.Invoke(8L, &num19);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num18);
				Llvm_lifetime_end_p0.Invoke(8L, &num17);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair9);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair8);
				Llvm_lifetime_end_p0.Invoke(8L, &b);
				Llvm_lifetime_end_p0.Invoke(8L, &num16);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair7);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair6);
				Llvm_lifetime_end_p0.Invoke(8L, &num15);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num14);
			Llvm_lifetime_end_p0.Invoke(8L, &num13);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair5);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			Llvm_lifetime_end_p0.Invoke(8L, &num12);
			Llvm_lifetime_end_p0.Invoke(8L, &num11);
			Llvm_lifetime_end_p0.Invoke(24L, &inlineArray3_Double2);
			Llvm_lifetime_end_p0.Invoke(8L, &num10);
			Llvm_lifetime_end_p0.Invoke(8L, &num9);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			Llvm_lifetime_end_p0.Invoke(8L, &num8);
			Llvm_lifetime_end_p0.Invoke(24L, &inlineArray3_Double);
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &num6);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &field_);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
			goto IL_19f0;
		}
		IL_19f0:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
