using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class CharVector_Destructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10CharVectorD2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::CharVector::~CharVector()")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_CharVector* This)
	{
		if (This->Cur_str != &This->Local_buffer)
		{
			Free.Invoke(This->Cur_str);
		}
	}
}
