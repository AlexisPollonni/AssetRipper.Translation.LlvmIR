using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10quick_multILm27EEENS_10NumberPairIdEERKS3_S5_")]
[DemangledName("__llvm_libc_20_1_2_::NumberPair<double> __llvm_libc_20_1_2_::fputil::quick_mult<27ul>(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
internal static partial class NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const
{
	public unsafe static Struct_4ydhja Invoke(NumberPair* a, NumberPair* b)
	{
		NumberPair numberPair = default(NumberPair);
		double z = 0.0;
		double num = 0.0;
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_exact_mult_27ul_double_double.Invoke(a->hi, b->hi);
			NumberPair* num2 = &numberPair;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja2.field_0;
			byte* num3 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num3 = struct_4ydhja3.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &z);
			z = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(a->hi, b->lo, numberPair.lo);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = (numberPair.lo = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(a->lo, b->hi, z));
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
