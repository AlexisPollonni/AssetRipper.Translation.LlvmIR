using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_1_set_sign
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE1EE8set_signENS_4SignE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::set_sign(__llvm_libc_20_1_2_::Sign)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("signVal.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte SignVal)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		anon_izyfb.Val = SignVal;
		anon_izyfb2.Val = FPStorage_fputil_FPType_1_sign.Invoke(This);
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &anon_izyfb, 1L, isVolatile: false);
		if (Llvm_libc_20_1_2_NotEquals_rpctvi.Invoke(anon_izyfb2.Val, anon_izyfb3.Val))
		{
			unchecked((Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 ^= int.MinValue;
		}
	}
}
