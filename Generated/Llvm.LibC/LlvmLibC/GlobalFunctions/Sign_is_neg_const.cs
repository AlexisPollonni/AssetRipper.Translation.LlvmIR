using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_4Sign6is_negEv")]
[DemangledName("__llvm_libc_20_1_2_::Sign::is_neg() const")]
internal static partial class Sign_is_neg_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((anon_izyfb7*)@this)->val & 1) == 1;
	}
}
