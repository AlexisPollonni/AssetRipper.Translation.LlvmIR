using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_abs
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE3ENS0_6FPBitsIgEEE3absEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>::abs() const")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("this")] void* This)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		unchecked
		{
			Int128 @int = NumericHelper.BitwiseAnd(((Fputil_internal_FPStorage_w3h7gw*)This)->field_0, -1L);
			FPBits_float128_FPBits_unsigned_int128.Invoke(&fputil_FPBits_ubgsi, *(long*)(&@int), ((long*)(&@int))[1]);
			return *(Struct_fiz2nb*)(&fputil_FPBits_ubgsi.Val.Data.FPStorage.field_0);
		}
	}
}
