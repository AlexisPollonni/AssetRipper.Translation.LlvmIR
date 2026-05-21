using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_add
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3addERKNS_10NumberPairIdEES4_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::add(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static Struct_4ydhja Invoke([MangledName("a")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] Llvm_libc_20_1_2_NumberPair* A, [MangledName("b")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] Llvm_libc_20_1_2_NumberPair* B)
	{
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		double num = 0.0;
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_exact_add_true.Invoke(A->Hi, B->Hi);
			Llvm_libc_20_1_2_NumberPair* num2 = &llvm_libc_20_1_2_NumberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja2.field_0;
			byte* num3 = (byte*)(&llvm_libc_20_1_2_NumberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num3 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = A->Lo + B->Lo;
			Struct_4ydhja struct_4ydhja4 = Fputil_exact_add_true.Invoke(llvm_libc_20_1_2_NumberPair2.Hi, llvm_libc_20_1_2_NumberPair2.Lo + num);
			Llvm_libc_20_1_2_NumberPair* num4 = &llvm_libc_20_1_2_NumberPair;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num4 = struct_4ydhja5.field_0;
			byte* num5 = (byte*)(&llvm_libc_20_1_2_NumberPair) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num5 = struct_4ydhja6.field_1;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			return *(Struct_4ydhja*)(&llvm_libc_20_1_2_NumberPair);
		}
	}
}
