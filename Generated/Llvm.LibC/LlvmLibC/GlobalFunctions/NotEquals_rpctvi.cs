using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NotEquals_rpctvi
{
	[MangledName("_ZN19__llvm_libc_20_1_2_neENS_4SignES0_")]
	[DemangledName("__llvm_libc_20_1_2_::operator!=(__llvm_libc_20_1_2_::Sign, __llvm_libc_20_1_2_::Sign)")]
	[CleanName("NotEquals")]
	public unsafe static bool Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte a, [MangledName("b.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte b)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb8.val = a;
		anon_izyfb9.val = b;
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb8, 1L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb9, 1L, isVolatile: false);
		return unchecked((byte)((Equals_fy8fvt.Invoke(anon_izyfb10.val, anon_izyfb11.val) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
