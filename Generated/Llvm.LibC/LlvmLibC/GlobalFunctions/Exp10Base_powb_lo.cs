using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exp10Base_powb_lo
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9Exp10Base7powb_loEd")]
	[DemangledName("__llvm_libc_20_1_2_::Exp10Base::powb_lo(double)")]
	public unsafe static double Invoke([MangledName("dx")][NativeType("double")] double Dx)
	{
		double x = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		Llvm_lifetime_start_p0.Invoke(8L, &x);
		x = Dx * Dx;
		Llvm_lifetime_start_p0.Invoke(8L, &a);
		unchecked
		{
			a = Fputil_multiply_add_double.Invoke(Dx, *(double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer, 1.0);
			Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = Fputil_multiply_add_double.Invoke(Dx, ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[2L], ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[1]);
			Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = Fputil_multiply_add_double.Invoke(Dx, ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[4L], ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[3L]);
			double result = Fputil_polyeval_double_double_double.Invoke(x, a, a_yc74sk, a_ijazrn);
			Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			Llvm_lifetime_end_p0.Invoke(8L, &a);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			return result;
		}
	}
}
