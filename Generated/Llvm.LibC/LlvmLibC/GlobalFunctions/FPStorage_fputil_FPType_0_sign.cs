using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_0_sign
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE4signEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::sign() const")]
	public unsafe static sbyte Invoke(void* @this)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, ((unchecked((ushort)((fputil_internal_FPStorage_za9n4f*)@this)->field_0) & 0x8000) == 0) ? Sign_POS.Pointer : Sign_NEG.Pointer, 1L, isVolatile: false);
		return anon_izyfb8.val;
	}
}
