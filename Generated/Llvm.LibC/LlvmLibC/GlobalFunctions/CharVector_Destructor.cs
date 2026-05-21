using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class CharVector_Destructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10CharVectorD2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::CharVector::~CharVector()")]
	public unsafe static void Invoke(CharVector* @this)
	{
		if (@this->cur_str != &@this->local_buffer)
		{
			free.Invoke(@this->cur_str);
		}
	}
}
