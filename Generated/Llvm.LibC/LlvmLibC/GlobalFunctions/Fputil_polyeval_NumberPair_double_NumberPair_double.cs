using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_polyeval_NumberPair_double_NumberPair_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalINS_10NumberPairIdEEJS3_EEENS_3cpp9enable_ifIXgtstT_Lm8EES6_E4typeERKS6_SA_DpRKT0_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__llvm_libc_20_1_2_::NumberPair<double>) > 8ul), __llvm_libc_20_1_2_::NumberPair<double>>::type __llvm_libc_20_1_2_::fputil::polyeval<__llvm_libc_20_1_2_::NumberPair<double>, __llvm_libc_20_1_2_::NumberPair<double>>(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__llvm_libc_20_1_2_::NumberPair<double>) > 8ul), __llvm_libc_20_1_2_::NumberPair<double>>::type")]
	public unsafe static Struct_4ydhja Invoke([MangledName("x")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* X, [MangledName("a0")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* A0, [MangledName("a")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* A)
	{
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		Llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
		Struct_4ydhja struct_4ydhja = Fputil_polyeval_NumberPair_double.Invoke(X, A);
		NumberPair* num = &numberPair2;
		Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
		unchecked
		{
			*(double*)num = struct_4ydhja2.field_0;
			byte* num2 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja3.field_1;
			Struct_4ydhja struct_4ydhja4 = Fputil_multiply_add_NumberPair_double.Invoke(X, &numberPair2, A0);
			NumberPair* num3 = &numberPair;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num3 = struct_4ydhja5.field_0;
			byte* num4 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num4 = struct_4ydhja6.field_1;
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
