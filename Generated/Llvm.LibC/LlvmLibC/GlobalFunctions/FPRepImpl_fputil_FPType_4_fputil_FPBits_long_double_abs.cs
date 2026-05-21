using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_abs
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE4ENS0_6FPBitsIeEEE3absEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::abs() const")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("this")] void* This)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		unchecked
		{
			Int128 @int = NumericHelper.BitwiseAnd(((Llvm_libc_20_1_2_fputil_internal_FPStorage_w3h7gw*)This)->field_0, -1L);
			FPBits_long_double_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&@int), ((long*)(&@int))[1]);
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi.Val.Data.FPStorage.field_0);
		}
	}
}
