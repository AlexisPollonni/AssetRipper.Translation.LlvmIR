using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_3_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EEC2Eo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::FPStorage(unsigned __int128)")]
	public unsafe static void Invoke(void* @this, [MangledName("value.coerce0")] long value, [MangledName("value.coerce1")] long value_coerce1)
	{
		Int128 field_ = default(Int128);
		unchecked
		{
			*(long*)(&field_) = value;
			((long*)(&field_))[1] = value_coerce1;
			((fputil_internal_FPStorage_w3h7gw*)@this)->field_0 = field_;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::FPStorage()")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked((fputil_internal_FPStorage_w3h7gw*)@this)->field_0 = 0L;
	}
}
