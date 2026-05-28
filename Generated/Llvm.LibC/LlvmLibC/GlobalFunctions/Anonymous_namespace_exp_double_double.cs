using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_exp_double_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_117exp_double_doubleEddRKNS_10NumberPairIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::exp_double_double(double, double, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static Struct_4ydhja Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("kd")][NativeType("double")] double Kd, [MangledName("exp_mid")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* Exp_mid)
	{
		NumberPair numberPair = default(NumberPair);
		double a = 0.0;
		double b = 0.0;
		double num = 0.0;
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		Llvm_lifetime_start_p0.Invoke(8L, &a);
		a = Fputil_multiply_add_double.Invoke(Kd, -0.00016922538588914904, X);
		Llvm_lifetime_start_p0.Invoke(8L, &b);
		b = Kd * 1.0256140311365355E-14;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Kd * 2.797449396191097E-24;
		Llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
		unchecked
		{
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_exact_add_true.Invoke(a, b);
			NumberPair* num2 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja2.field_0;
			byte* num3 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num3 = struct_4ydhja3.field_1;
			numberPair2.Lo += num;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Anonymous_namespace_poly_approx_dd_z6hacd.Invoke(&numberPair2);
			NumberPair* num4 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num4 = struct_4ydhja5.field_0;
			byte* num5 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num5 = struct_4ydhja6.field_1;
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = Fputil_quick_mult_27ul.Invoke(Exp_mid, &numberPair3);
			NumberPair* num6 = &numberPair;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num6 = struct_4ydhja8.field_0;
			byte* num7 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num7 = struct_4ydhja9.field_1;
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &a);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_117exp_double_doubleEddRKNS_10NumberPairIdEES4_")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::exp_double_double(double, double, __llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static Struct_4ydhja Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("kd")][NativeType("double")] double Kd, [MangledName("exp_mid")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* Exp_mid, [MangledName("hi_part")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* Hi_part)
	{
		NumberPair numberPair = default(NumberPair);
		double a = 0.0;
		double b = 0.0;
		double num = 0.0;
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		NumberPair numberPair4 = default(NumberPair);
		Llvm_lifetime_start_p0.Invoke(8L, &a);
		a = Fputil_multiply_add_double.Invoke(Kd, -0.00016922538588914904, X);
		Llvm_lifetime_start_p0.Invoke(8L, &b);
		b = Kd * 1.0256140311365355E-14;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Kd * 2.797449396191097E-24;
		Llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
		unchecked
		{
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_exact_add_true.Invoke(a, b);
			NumberPair* num2 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja2.field_0;
			byte* num3 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num3 = struct_4ydhja3.field_1;
			numberPair2.Lo += num;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Anonymous_namespace_poly_approx_dd_2k4f32.Invoke(&numberPair2);
			NumberPair* num4 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num4 = struct_4ydhja5.field_0;
			byte* num5 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num5 = struct_4ydhja6.field_1;
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			Struct_4ydhja struct_4ydhja7 = Fputil_quick_mult_27ul.Invoke(Exp_mid, &numberPair2);
			NumberPair* num6 = &numberPair4;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num6 = struct_4ydhja8.field_0;
			byte* num7 = (byte*)(&numberPair4) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num7 = struct_4ydhja9.field_1;
			Struct_4ydhja struct_4ydhja10 = Fputil_multiply_add_NumberPair_double.Invoke(&numberPair4, &numberPair3, Hi_part);
			NumberPair* num8 = &numberPair;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num8 = struct_4ydhja11.field_0;
			byte* num9 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num9 = struct_4ydhja12.field_1;
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &a);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
