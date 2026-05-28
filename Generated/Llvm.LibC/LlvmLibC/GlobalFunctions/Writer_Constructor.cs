using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Writer_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6WriterC2EPNS0_11WriteBufferE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer::Writer(__llvm_libc_20_1_2_::printf_core::WriteBuffer*)")]
	public unsafe static void Invoke([MangledName("this")] Printf_core_Writer* This, [NativeType("__llvm_libc_20_1_2_::printf_core::WriteBuffer*")] Printf_core_WriteBuffer* WB)
	{
		This->Wb = WB;
		This->Chars_written = 0;
	}
}
