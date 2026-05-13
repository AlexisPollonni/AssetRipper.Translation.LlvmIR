using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 110)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues.1536")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("fputil_ExceptValues")]
public partial struct fputil_ExceptValues_dwtyzi
{
	[FieldOffset(0)]
	public InlineArray11_fputil_ExceptValues_Float16_21_Mapping values;
}
