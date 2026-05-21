using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class CharVector_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10CharVectorC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::CharVector::CharVector()")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_CharVector* This)
	{
		This->Cur_str = &This->Local_buffer;
		This->Cur_buff_size = 64L;
		This->Index = 0L;
	}
}
