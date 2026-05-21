using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_exp2_double_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_118exp2_double_doubleEdRKNS_10NumberPairIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::exp2_double_double(double, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static Struct_4ydhja Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("exp_mid")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] Llvm_libc_20_1_2_NumberPair* Exp_mid)
	{
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
			llvm_libc_20_1_2_NumberPair2.Lo = 0.0;
			llvm_libc_20_1_2_NumberPair2.Hi = X;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			*(double*)(&llvm_libc_20_1_2_NumberPair3) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Anonymous_namespace_poly_approx_dd_7mmuzy.Invoke(&llvm_libc_20_1_2_NumberPair2);
			Llvm_libc_20_1_2_NumberPair* num = &llvm_libc_20_1_2_NumberPair3;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num = struct_4ydhja2.field_0;
			byte* num2 = (byte*)(&llvm_libc_20_1_2_NumberPair3) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja3.field_1;
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Fputil_quick_mult_27ul.Invoke(Exp_mid, &llvm_libc_20_1_2_NumberPair3);
			Llvm_libc_20_1_2_NumberPair* num3 = &llvm_libc_20_1_2_NumberPair;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num3 = struct_4ydhja5.field_0;
			byte* num4 = (byte*)(&llvm_libc_20_1_2_NumberPair) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num4 = struct_4ydhja6.field_1;
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			return *(Struct_4ydhja*)(&llvm_libc_20_1_2_NumberPair);
		}
	}
}
