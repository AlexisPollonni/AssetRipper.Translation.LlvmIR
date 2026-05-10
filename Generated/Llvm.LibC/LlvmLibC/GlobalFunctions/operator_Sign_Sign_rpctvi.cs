using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_neENS_4SignES0_")]
[DemangledName("__llvm_libc_20_1_2_::operator!=(__llvm_libc_20_1_2_::Sign, __llvm_libc_20_1_2_::Sign)")]
[CleanName("operator_Sign_Sign")]
internal static partial class operator_Sign_Sign_rpctvi
{
	public unsafe static bool Invoke([MangledName("a.coerce")] sbyte a, [MangledName("b.coerce")] sbyte b)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb8.val = a;
		anon_izyfb9.val = b;
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb8, 1L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb9, 1L, isVolatile: false);
		return unchecked((byte)((operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb10.val, anon_izyfb11.val) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
