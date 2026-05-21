using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_3_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EEC2Eo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::FPStorage(unsigned __int128)")]
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

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::FPStorage()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		unchecked((Llvm_libc_20_1_2_fputil_internal_FPStorage_w3h7gw*)This)->field_0 = 0L;
	}
}
