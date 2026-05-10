using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 210)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("fputil_ExceptValues")]
public partial struct fputil_ExceptValues_qu7rez
{
	[FieldOffset(0)]
	public InlineArray21_fputil_ExceptValues_Float16_21_Mapping values;
}
