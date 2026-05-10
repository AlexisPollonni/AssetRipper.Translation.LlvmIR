using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_4Sign6is_posEv")]
[DemangledName("__llvm_libc_20_1_2_::Sign::is_pos() const")]
internal static partial class Sign_is_pos_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((byte)((((((anon_izyfb7*)@this)->val & 1) == 1) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
