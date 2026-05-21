using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class anonymous_namespace_exp2_double_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_118exp2_double_doubleEdRKNS_10NumberPairIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::exp2_double_double(double, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static Struct_4ydhja Invoke([NativeType("double")] double x, [NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* exp_mid)
	{
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
		unchecked
		{
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			numberPair2.lo = 0.0;
			numberPair2.hi = x;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = anonymous_namespace_poly_approx_dd_7mmuzy.Invoke(&numberPair2);
			NumberPair* num = &numberPair3;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num = struct_4ydhja2.field_0;
			byte* num2 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja3.field_1;
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = fputil_quick_mult_27ul.Invoke(exp_mid, &numberPair3);
			NumberPair* num3 = &numberPair;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num3 = struct_4ydhja5.field_0;
			byte* num4 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num4 = struct_4ydhja6.field_1;
			llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
