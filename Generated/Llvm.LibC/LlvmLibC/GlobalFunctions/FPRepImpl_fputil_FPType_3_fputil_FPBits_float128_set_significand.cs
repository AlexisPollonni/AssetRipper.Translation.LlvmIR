using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_set_significand
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE3ENS0_6FPBitsIgEEE15set_significandEo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>::set_significand(unsigned __int128)")]
	public unsafe static void Invoke(void* @this, [MangledName("sigVal.coerce0")] long sigVal, [MangledName("sigVal.coerce1")] long sigVal_coerce1)
	{
		Int128 @int = default(Int128);
		Int128 field_ = default(Int128);
		unchecked
		{
			*(long*)(&@int) = sigVal;
			((long*)(&@int))[1] = sigVal_coerce1;
			Int128 int2 = @int;
			Int128 field_2 = ((fputil_internal_FPStorage_w3h7gw*)@this)->field_0;
			long a = *(long*)(&field_2);
			long b = ((long*)(&field_2))[1];
			Int128 int3 = int2;
			long mask = *(long*)(&int3);
			long b_coerce = ((long*)(&int3))[1];
			Int128 int4 = -1L;
			Struct_fiz2nb struct_fiz2nb = FPStorage_fputil_FPType_3_merge.Invoke(a, b, mask, b_coerce, *(long*)(&int4), ((long*)(&int4))[1]);
			Int128* num = &field_;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&field_) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			((fputil_internal_FPStorage_w3h7gw*)@this)->field_0 = field_;
		}
	}
}
