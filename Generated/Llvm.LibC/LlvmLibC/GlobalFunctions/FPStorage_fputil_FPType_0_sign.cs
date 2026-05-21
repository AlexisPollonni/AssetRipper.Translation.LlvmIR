using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_0_sign
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE4signEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::sign() const")]
	public unsafe static sbyte Invoke([MangledName("this")] void* This)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, ((unchecked((ushort)((Llvm_libc_20_1_2_fputil_internal_FPStorage_za9n4f*)This)->field_0) & 0x8000) == 0) ? Llvm_libc_20_1_2_Sign_POS.Pointer : Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
		return anon_izyfb.Val;
	}
}
