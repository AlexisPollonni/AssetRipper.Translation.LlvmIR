using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 60)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues.2428")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("fputil_ExceptValues")]
public partial struct fputil_ExceptValues_susv2z
{
	[FieldOffset(0)]
	public InlineArray6_fputil_ExceptValues_Float16_21_Mapping values;
}
