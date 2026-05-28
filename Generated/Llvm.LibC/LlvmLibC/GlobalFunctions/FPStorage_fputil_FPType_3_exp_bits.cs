using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_3_exp_bits
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE8exp_bitsEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::exp_bits() const")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("this")] void* This)
	{
		unchecked
		{
			Int128 @int = NumericHelper.BitwiseAnd(((Fputil_internal_FPStorage_w3h7gw*)This)->field_0, 0L);
			return *(Struct_fiz2nb*)(&@int);
		}
	}
}
