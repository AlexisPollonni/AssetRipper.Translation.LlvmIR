using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_4_set_sign
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE4EE8set_signENS_4SignE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::set_sign(__llvm_libc_20_1_2_::Sign)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("signVal.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte SignVal)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		anon_izyfb.Val = SignVal;
		anon_izyfb2.Val = FPStorage_fputil_FPType_4_sign.Invoke(This);
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &anon_izyfb, 1L, isVolatile: false);
		if (NotEquals_rpctvi.Invoke(anon_izyfb2.Val, anon_izyfb3.Val))
		{
			Int128* field_ = &unchecked((Fputil_internal_FPStorage_w3h7gw*)This)->field_0;
			*field_ = NumericHelper.BitwiseXor(*field_, 0L);
		}
	}
}
