using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_eqENS_4SignES0_")]
[DemangledName("__llvm_libc_20_1_2_::operator==(__llvm_libc_20_1_2_::Sign, __llvm_libc_20_1_2_::Sign)")]
[CleanName("operator_Sign_Sign")]
internal static partial class operator_Sign_Sign_fy8fvt
{
	public static bool Invoke([MangledName("a.coerce")] sbyte a, [MangledName("b.coerce")] sbyte b)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb8.val = a;
		anon_izyfb9.val = b;
		return (anon_izyfb8.val & 1) == 1 == ((anon_izyfb9.val & 1) == 1);
	}
}
