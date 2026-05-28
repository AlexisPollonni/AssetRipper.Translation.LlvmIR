using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Equals_fy8fvt
{
	[MangledName("_ZN19__llvm_libc_20_1_2_eqENS_4SignES0_")]
	[DemangledName("__llvm_libc_20_1_2_::operator==(__llvm_libc_20_1_2_::Sign, __llvm_libc_20_1_2_::Sign)")]
	[CleanName("Equals")]
	public static bool Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte A, [MangledName("b.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte B)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		anon_izyfb.Val = A;
		anon_izyfb2.Val = B;
		return (anon_izyfb.Val & 1) == 1 == ((anon_izyfb2.Val & 1) == 1);
	}
}
