using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NotEquals_rpctvi
{
	[MangledName("_ZN19__llvm_libc_20_1_2_neENS_4SignES0_")]
	[DemangledName("__llvm_libc_20_1_2_::operator!=(__llvm_libc_20_1_2_::Sign, __llvm_libc_20_1_2_::Sign)")]
	[CleanName("NotEquals")]
	public unsafe static bool Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte A, [MangledName("b.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte B)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		anon_izyfb.Val = A;
		anon_izyfb2.Val = B;
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &anon_izyfb, 1L, isVolatile: false);
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, &anon_izyfb2, 1L, isVolatile: false);
		return InstructionHelper.BooleanXor(Equals_fy8fvt.Invoke(anon_izyfb3.Val, anon_izyfb4.Val), right: true);
	}
}
