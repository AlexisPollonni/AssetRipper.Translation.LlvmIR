using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE4signEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::sign() const")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_3_sign_const
{
	public unsafe static sbyte Invoke(void* @this)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, (!NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(unchecked((fputil_internal_FPStorage_w3h7gw*)@this)->field_0, 0L), 0L)) ? Sign_POS.Pointer : Sign_NEG.Pointer, 1L, isVolatile: false);
		return anon_izyfb8.val;
	}
}
