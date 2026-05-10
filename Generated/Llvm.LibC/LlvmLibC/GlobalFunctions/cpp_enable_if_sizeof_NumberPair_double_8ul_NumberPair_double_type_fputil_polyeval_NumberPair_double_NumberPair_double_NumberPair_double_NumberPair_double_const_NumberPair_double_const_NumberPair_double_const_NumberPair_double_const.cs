using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalINS_10NumberPairIdEEJS3_S3_EEENS_3cpp9enable_ifIXgtstT_Lm8EES6_E4typeERKS6_SA_DpRKT0_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__llvm_libc_20_1_2_::NumberPair<double>) > 8ul), __llvm_libc_20_1_2_::NumberPair<double>>::type __llvm_libc_20_1_2_::fputil::polyeval<__llvm_libc_20_1_2_::NumberPair<double>, __llvm_libc_20_1_2_::NumberPair<double>, __llvm_libc_20_1_2_::NumberPair<double>>(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
internal static partial class cpp_enable_if_sizeof_NumberPair_double_8ul_NumberPair_double_type_fputil_polyeval_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const
{
	public unsafe static Struct_4ydhja Invoke(void* x, void* a0, [MangledName("a")][CleanName("a")] void* a_yc74sk, [MangledName("a1")][CleanName("a")] void* a_ijazrn)
	{
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
		Struct_4ydhja struct_4ydhja = cpp_enable_if_sizeof_NumberPair_double_8ul_NumberPair_double_type_fputil_polyeval_NumberPair_double_NumberPair_double_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const.Invoke(x, a_yc74sk, a_ijazrn);
		NumberPair* num = &numberPair2;
		Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
		unchecked
		{
			*(double*)num = struct_4ydhja2.field_0;
			byte* num2 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja3.field_1;
			Struct_4ydhja struct_4ydhja4 = cpp_enable_if_sizeof_NumberPair_double_8ul_NumberPair_double_type_fputil_multiply_add_NumberPair_double_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const.Invoke(x, &numberPair2, a0);
			NumberPair* num3 = &numberPair;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num3 = struct_4ydhja5.field_0;
			byte* num4 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num4 = struct_4ydhja6.field_1;
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
