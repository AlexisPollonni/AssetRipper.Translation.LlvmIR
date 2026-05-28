using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_div
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3divERKNS_10NumberPairIdEES4_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::div(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static Struct_4ydhja Invoke([MangledName("a")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* A, [MangledName("b")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* B)
	{
		NumberPair numberPair = default(NumberPair);
		double num = 0.0;
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double num2 = 0.0;
		double num3 = 0.0;
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&numberPair);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 1.0 / B->Hi;
			numberPair.Hi = A->Hi * num;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_exact_mult_27ul.Invoke(B->Hi, 0.0 - numberPair.Hi);
			NumberPair* num4 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num4 = struct_4ydhja2.field_0;
			byte* num5 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num5 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Fputil_exact_mult_27ul.Invoke(B->Lo, 0.0 - numberPair.Hi);
			NumberPair* num6 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num6 = struct_4ydhja5.field_0;
			byte* num7 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num7 = struct_4ydhja6.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = A->Hi + numberPair2.Hi + numberPair2.Lo;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = A->Lo + numberPair3.Hi + numberPair3.Lo;
			numberPair.Lo = num * (num2 + num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
