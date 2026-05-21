using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_infer_base
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal10infer_baseEPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::infer_base(char const*, unsigned long)")]
	public unsafe static int Invoke([MangledName("src")][NativeType("char const*")] void* Src, [MangledName("src_len")][NativeType("unsigned long")] long Src_len)
	{
		if (Internal_is_hex_start.Invoke(Src, Src_len))
		{
			return 16;
		}
		if (unchecked((ulong)Src_len > 0uL && *(sbyte*)Src == 48))
		{
			return 8;
		}
		return 10;
	}
}
