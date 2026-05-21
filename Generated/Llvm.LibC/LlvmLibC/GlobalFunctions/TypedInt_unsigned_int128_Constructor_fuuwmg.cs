using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class TypedInt_unsigned_int128_Constructor_fuuwmg
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE4EE8TypedIntIoEC2Eo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::TypedInt<unsigned __int128>::TypedInt(unsigned __int128)")]
	[CleanName("TypedInt_unsigned_int128_Constructor")]
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
}
