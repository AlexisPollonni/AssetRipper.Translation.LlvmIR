using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_float128_FPBits_unsigned_int128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIgEC2IoEET_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<__float128>::FPBits<unsigned __int128>(unsigned __int128)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("x.coerce0")] long X, [MangledName("x.coerce1")] long X_coerce1)
	{
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&@int) = X;
			((long*)(&@int))[1] = X_coerce1;
			Int128 field_ = @int;
			FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_Constructor.Invoke(This);
			((Llvm_libc_20_1_2_fputil_internal_FPStorage_w3h7gw*)This)->field_0 = field_;
		}
	}
}
