using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class TypedInt_unsigned_int128_Constructor_776834
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE8TypedIntIoEC2Eo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::TypedInt<unsigned __int128>::TypedInt(unsigned __int128)")]
	[CleanName("TypedInt_unsigned_int128_Constructor")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value.coerce0")] long Value, [MangledName("value.coerce1")] long Value_coerce1)
	{
		Int128 field_ = default(Int128);
		unchecked
		{
			*(long*)(&field_) = Value;
			((long*)(&field_))[1] = Value_coerce1;
			((Llvm_libc_20_1_2_fputil_internal_FPStorage_w3h7gw*)This)->field_0 = field_;
		}
	}
}
