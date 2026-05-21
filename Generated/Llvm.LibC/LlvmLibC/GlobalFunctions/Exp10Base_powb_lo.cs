using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exp10Base_powb_lo
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9Exp10Base7powb_loEd")]
	[DemangledName("__llvm_libc_20_1_2_::Exp10Base::powb_lo(double)")]
	public unsafe static double Invoke([NativeType("double")] double dx)
	{
		double x = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &x);
		x = dx * dx;
		llvm_lifetime_start_p0.Invoke(8L, &a);
		unchecked
		{
			a = fputil_multiply_add_double.Invoke(dx, *(double*)Exp10Base_COEFFS.Pointer, 1.0);
			llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = fputil_multiply_add_double.Invoke(dx, ((double*)Exp10Base_COEFFS.Pointer)[2L], ((double*)Exp10Base_COEFFS.Pointer)[1]);
			llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = fputil_multiply_add_double.Invoke(dx, ((double*)Exp10Base_COEFFS.Pointer)[4L], ((double*)Exp10Base_COEFFS.Pointer)[3L]);
			double result = fputil_polyeval_double_double_double.Invoke(x, a, a_yc74sk, a_ijazrn);
			llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			llvm_lifetime_end_p0.Invoke(8L, &a);
			llvm_lifetime_end_p0.Invoke(8L, &x);
			return result;
		}
	}
}
