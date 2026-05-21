using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_div
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3divERKNS_10NumberPairIdEES4_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::div(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static Struct_4ydhja Invoke([MangledName("a")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] Llvm_libc_20_1_2_NumberPair* A, [MangledName("b")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] Llvm_libc_20_1_2_NumberPair* B)
	{
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		double num = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		double num2 = 0.0;
		double num3 = 0.0;
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&llvm_libc_20_1_2_NumberPair);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 1.0 / B->Hi;
			llvm_libc_20_1_2_NumberPair.Hi = A->Hi * num;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_exact_mult_27ul.Invoke(B->Hi, 0.0 - llvm_libc_20_1_2_NumberPair.Hi);
			Llvm_libc_20_1_2_NumberPair* num4 = &llvm_libc_20_1_2_NumberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num4 = struct_4ydhja2.field_0;
			byte* num5 = (byte*)(&llvm_libc_20_1_2_NumberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num5 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			*(double*)(&llvm_libc_20_1_2_NumberPair3) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Fputil_exact_mult_27ul.Invoke(B->Lo, 0.0 - llvm_libc_20_1_2_NumberPair.Hi);
			Llvm_libc_20_1_2_NumberPair* num6 = &llvm_libc_20_1_2_NumberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num6 = struct_4ydhja5.field_0;
			byte* num7 = (byte*)(&llvm_libc_20_1_2_NumberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num7 = struct_4ydhja6.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = A->Hi + llvm_libc_20_1_2_NumberPair2.Hi + llvm_libc_20_1_2_NumberPair2.Lo;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = A->Lo + llvm_libc_20_1_2_NumberPair3.Hi + llvm_libc_20_1_2_NumberPair3.Lo;
			llvm_libc_20_1_2_NumberPair.Lo = num * (num2 + num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&llvm_libc_20_1_2_NumberPair);
		}
	}
}
