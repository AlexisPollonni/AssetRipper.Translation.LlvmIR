using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 40)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues.1233")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("fputil_ExceptValues")]
public partial struct fputil_ExceptValues_pfsijn
{
	[FieldOffset(0)]
	public InlineArray4_fputil_ExceptValues_Float16_21_Mapping values;
}
