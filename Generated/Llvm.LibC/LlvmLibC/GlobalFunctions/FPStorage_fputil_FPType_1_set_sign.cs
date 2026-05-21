using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_1_set_sign
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE1EE8set_signENS_4SignE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::set_sign(__llvm_libc_20_1_2_::Sign)")]
	public unsafe static void Invoke(void* @this, [MangledName("signVal.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte signVal)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb8.val = signVal;
		anon_izyfb9.val = FPStorage_fputil_FPType_1_sign.Invoke(@this);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb8, 1L, isVolatile: false);
		if (NotEquals_rpctvi.Invoke(anon_izyfb9.val, anon_izyfb10.val))
		{
			unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 ^= int.MinValue;
		}
	}
}
