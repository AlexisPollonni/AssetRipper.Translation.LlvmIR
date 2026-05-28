using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Log2f
{
	[MangledName("log2f")]
	[DemangledName("log2f")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(Fputil_FPBits_5nkvcs);
		int num3 = 0;
		float num4 = 0f;
		double num5 = 0.0;
		double z = 0.0;
		InlineArray5_Double inlineArray5_Double = default(InlineArray5_Double);
		double x = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double num6 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		float result;
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = -127;
			if (Details_expects_bool_condition_bool.Invoke(num == 1065353216, Expected: false))
			{
				result = 0f;
			}
			else
			{
				int num7 = num;
				Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_normal.Invoke(anon_izyfb.Val);
				fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				bool num8 = (uint)num7 < (uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
				Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				int value;
				if (num8)
				{
					value = 1;
				}
				else
				{
					int num9 = num;
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb2.Val);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					value = (((uint)num9 > (uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3))) ? 1 : 0);
				}
				bool num10 = Details_expects_bool_condition_bool.Invoke((byte)value != 0, Expected: false);
				Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				if (!num10)
				{
					goto IL_0384;
				}
				if (X == 0f)
				{
					Fputil_set_errno_if_required.Invoke(34);
					Fputil_raise_except_if_required.Invoke(4);
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_NEG.Pointer, 1L, isVolatile: false);
					int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb3.Val);
					fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				}
				else if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) && !FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs))
				{
					Fputil_set_errno_if_required.Invoke(33);
					Fputil_raise_except.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_4 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb4.Val, 0);
					fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs5);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
				}
				else
				{
					if (!FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)))
					{
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs6, FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs) * 8388608f);
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs, &fputil_FPBits_5nkvcs6, 4L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						num2 = checked(num2 - 23);
						goto IL_0384;
					}
					result = X;
				}
			}
			goto IL_0639;
		}
		IL_0639:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		return result;
		IL_0384:
		int num11 = unchecked((ushort)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)));
		num2 += num11;
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		unchecked
		{
			num3 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) >>> 16;
			FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs), 127);
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = double.NaN;
			double x2 = num4;
			long num12 = num3;
			num5 = Fputil_multiply_add_double.Invoke(x2, ((double*)RD.Pointer)[num12], -1.0);
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			double num13 = num2;
			long num14 = num3;
			z = num13 + ((double*)LOG2_R.Pointer)[num14];
			Llvm_lifetime_start_p0.Invoke(40L, &inlineArray5_Double);
			Llvm_memset_p0_i64.Invoke(&inlineArray5_Double, 0, 40L, isVolatile: false);
			*(double*)(&inlineArray5_Double) = 1.4426950408888615;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))) = -0.7213475204561689;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * (nint)sizeof(double))) = 0.48089838914330396;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * (nint)sizeof(double))) = -0.3606749445241509;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * (nint)sizeof(double))) = 0.28621288485764806;
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = num5 * num5;
			Llvm_lifetime_start_p0.Invoke(8L, &a);
			a = Fputil_multiply_add_double.Invoke(num5, *(double*)(&inlineArray5_Double), z);
			Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = Fputil_multiply_add_double.Invoke(num5, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = Fputil_multiply_add_double.Invoke(num5, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = Fputil_polyeval_double_double_double.Invoke(x, a, a_yc74sk, a_ijazrn);
			result = (float)num6;
			Llvm_lifetime_end_p0.Invoke(8L, &num6);
			Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			Llvm_lifetime_end_p0.Invoke(8L, &a);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(40L, &inlineArray5_Double);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			goto IL_0639;
		}
	}
}
