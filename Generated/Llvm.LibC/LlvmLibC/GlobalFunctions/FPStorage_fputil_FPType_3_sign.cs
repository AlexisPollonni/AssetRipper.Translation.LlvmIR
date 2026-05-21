using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_3_sign
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE4signEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::sign() const")]
	public unsafe static sbyte Invoke([MangledName("this")] void* This)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, (!NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(unchecked((Llvm_libc_20_1_2_fputil_internal_FPStorage_w3h7gw*)This)->field_0, 0L), 0L)) ? Llvm_libc_20_1_2_Sign_POS.Pointer : Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
		return anon_izyfb.Val;
	}
}
