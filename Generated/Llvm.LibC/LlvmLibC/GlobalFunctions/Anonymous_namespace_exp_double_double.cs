using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_exp_double_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_117exp_double_doubleEddRKNS_10NumberPairIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::exp_double_double(double, double, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static Struct_4ydhja Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("kd")][NativeType("double")] double Kd, [MangledName("exp_mid")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] Llvm_libc_20_1_2_NumberPair* Exp_mid)
	{
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		double a = 0.0;
		double b = 0.0;
		double num = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_lifetime_start_p0.Invoke(8L, &a);
		a = Fputil_multiply_add_double.Invoke(Kd, -0.00016922538588914904, X);
		Llvm_lifetime_start_p0.Invoke(8L, &b);
		b = Kd * 1.0256140311365355E-14;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Kd * 2.797449396191097E-24;
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_exact_add_true.Invoke(a, b);
			Llvm_libc_20_1_2_NumberPair* num2 = &llvm_libc_20_1_2_NumberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja2.field_0;
			byte* num3 = (byte*)(&llvm_libc_20_1_2_NumberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num3 = struct_4ydhja3.field_1;
			llvm_libc_20_1_2_NumberPair2.Lo += num;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			*(double*)(&llvm_libc_20_1_2_NumberPair3) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Anonymous_namespace_poly_approx_dd_z6hacd.Invoke(&llvm_libc_20_1_2_NumberPair2);
			Llvm_libc_20_1_2_NumberPair* num4 = &llvm_libc_20_1_2_NumberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num4 = struct_4ydhja5.field_0;
			byte* num5 = (byte*)(&llvm_libc_20_1_2_NumberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num5 = struct_4ydhja6.field_1;
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = Fputil_quick_mult_27ul.Invoke(Exp_mid, &llvm_libc_20_1_2_NumberPair3);
			Llvm_libc_20_1_2_NumberPair* num6 = &llvm_libc_20_1_2_NumberPair;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num6 = struct_4ydhja8.field_0;
			byte* num7 = (byte*)(&llvm_libc_20_1_2_NumberPair) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num7 = struct_4ydhja9.field_1;
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &a);
			return *(Struct_4ydhja*)(&llvm_libc_20_1_2_NumberPair);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_117exp_double_doubleEddRKNS_10NumberPairIdEES4_")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::exp_double_double(double, double, __llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static Struct_4ydhja Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("kd")][NativeType("double")] double Kd, [MangledName("exp_mid")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] Llvm_libc_20_1_2_NumberPair* Exp_mid, [MangledName("hi_part")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] Llvm_libc_20_1_2_NumberPair* Hi_part)
	{
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		double a = 0.0;
		double b = 0.0;
		double num = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair4 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_lifetime_start_p0.Invoke(8L, &a);
		a = Fputil_multiply_add_double.Invoke(Kd, -0.00016922538588914904, X);
		Llvm_lifetime_start_p0.Invoke(8L, &b);
		b = Kd * 1.0256140311365355E-14;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Kd * 2.797449396191097E-24;
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_exact_add_true.Invoke(a, b);
			Llvm_libc_20_1_2_NumberPair* num2 = &llvm_libc_20_1_2_NumberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja2.field_0;
			byte* num3 = (byte*)(&llvm_libc_20_1_2_NumberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num3 = struct_4ydhja3.field_1;
			llvm_libc_20_1_2_NumberPair2.Lo += num;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			*(double*)(&llvm_libc_20_1_2_NumberPair3) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Anonymous_namespace_poly_approx_dd_2k4f32.Invoke(&llvm_libc_20_1_2_NumberPair2);
			Llvm_libc_20_1_2_NumberPair* num4 = &llvm_libc_20_1_2_NumberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num4 = struct_4ydhja5.field_0;
			byte* num5 = (byte*)(&llvm_libc_20_1_2_NumberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num5 = struct_4ydhja6.field_1;
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			Struct_4ydhja struct_4ydhja7 = Fputil_quick_mult_27ul.Invoke(Exp_mid, &llvm_libc_20_1_2_NumberPair2);
			Llvm_libc_20_1_2_NumberPair* num6 = &llvm_libc_20_1_2_NumberPair4;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num6 = struct_4ydhja8.field_0;
			byte* num7 = (byte*)(&llvm_libc_20_1_2_NumberPair4) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num7 = struct_4ydhja9.field_1;
			Struct_4ydhja struct_4ydhja10 = Fputil_multiply_add_NumberPair_double.Invoke(&llvm_libc_20_1_2_NumberPair4, &llvm_libc_20_1_2_NumberPair3, Hi_part);
			Llvm_libc_20_1_2_NumberPair* num8 = &llvm_libc_20_1_2_NumberPair;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num8 = struct_4ydhja11.field_0;
			byte* num9 = (byte*)(&llvm_libc_20_1_2_NumberPair) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num9 = struct_4ydhja12.field_1;
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &a);
			return *(Struct_4ydhja*)(&llvm_libc_20_1_2_NumberPair);
		}
	}
}
