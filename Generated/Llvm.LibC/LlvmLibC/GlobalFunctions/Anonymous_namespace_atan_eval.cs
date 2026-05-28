using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_atan_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_19atan_evalERKNS_10NumberPairIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::atan_eval(__llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static Struct_4ydhja Invoke([MangledName("x")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* X)
	{
		NumberPair numberPair = default(NumberPair);
		double num = 0.0;
		double z = 0.0;
		double y = 0.0;
		double x = 0.0;
		double num2 = 0.0;
		double y2 = 0.0;
		double z2 = 0.0;
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&numberPair);
			numberPair.Hi = X->Hi;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = X->Hi * X->Hi;
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			z = Fputil_multiply_add_double.Invoke(num, 0.2, -1.0 / 3.0);
			Llvm_lifetime_start_p0.Invoke(8L, &y);
			y = Fputil_multiply_add_double.Invoke(num, 1.0 / 9.0, -1.0 / 7.0);
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = num * X->Hi;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = num * num;
			Llvm_lifetime_start_p0.Invoke(8L, &y2);
			y2 = Fputil_multiply_add_double.Invoke(num2, y, z);
			Llvm_lifetime_start_p0.Invoke(8L, &z2);
			z2 = Fputil_multiply_add_double.Invoke(num2 - num, X->Lo, X->Lo);
			numberPair.Lo = Fputil_multiply_add_double.Invoke(x, y2, z2);
			Llvm_lifetime_end_p0.Invoke(8L, &z2);
			Llvm_lifetime_end_p0.Invoke(8L, &y2);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &y);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
