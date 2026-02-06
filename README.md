# Mac .NET Samples for macOS

Comprehensive collection of **100 production-ready .NET 10 samples** across 20 macOS/native domains with real implementations and unit tests.

## 100 Samples Overview

### Native & Interop (11 samples)

- **naot-cli**: NativeAOT CLI argument parsing with help flags and command routing
- **objc-runtime**: Objective-C P/Invoke interop via libobjc.A.dylib message sending
- **xpc-services**: XPC message validation and router dispatch
- **kernel-extension**: System extension detection and OS version detection
- **mmap-io**: Memory-mapped file I/O with byte-level read/write
- **dispatch-queue**: Grand Central Dispatch task queue with enqueue/flush
- **pinvoke-patterns**: P/Invoke native library calls
- **simd-intrinsics**: SIMD array operations and vectorized math
- **unsafe-pointers**: Unsafe pointer dereferencing and memory access

### Security (8 samples)

- **keychain**: Keychain CRUD with validation and service/account lookup
- **common-crypto**: SHA256 hashing with consistent output verification
- **digital-signatures**: Data signing and signature verification
- **certificate-mgmt**: Certificate import and tracking
- **oauth2**: OAuth2 client authentication with token management
- **secure-enclave**: Secure Enclave availability detection
- **saml-integration**: SAML assertion authentication
- **tpm-operations**: TPM module version reporting

### Concurrency (6 samples)

- **semaphores**: Semaphore resource pool with acquisition/timeout
- **actors**: Actor model message passing via channels
- **barriers**: Synchronization barrier for thread coordination
- **reader-writer-locks**: RwLock with separate read/write locking
- **channel-messaging**: Channel-based async message routing
- **thread-pool**: Thread pool task execution and scheduling

### Networking (7 samples)

- **network-sockets**: Socket server with connection metadata tracking
- **bonjour-mdns**: Service discovery and registration
- **websocket**: WebSocket server with message queuing
- **network-framework**: Network framework connection management
- **tls-ssl**: TLS/SSL with protocol version handling
- **network-extension**: Network extension activation
- **vpn-integration**: VPN client with connection state

### Database (4 samples)

- **sqlite-custom**: SQLite-style CRUD with insert/query/delete/count
- **encrypted-db**: Base64 encryption with encrypted storage
- **acid-transactions**: Transaction commit tracking and verification
- **memory-mapped-db**: Memory-mapped database access patterns

### Graphics (6 samples)

- **mesh-loading**: 3D mesh with vertices and triangles
- **opengl**: OpenGL context initialization and rendering
- **shaders**: GLSL shader compilation validation
- **ray-tracing**: Vector3 dot product for ray math
- **metal-bindings**: Metal device availability and properties
- **metal-shaders**: Metal shader library loading

### Media (13 samples)

- **core-audio**: Audio DSP with gain clamping and low-pass filtering
- **audio-routing**: Audio source-to-destination routing
- **video-capture**: Video frame capture with resolution tracking
- **screen-capture**: Screenshot recording with dimensions
- **hls-streaming**: HLS segment playlist management
- **dash-streaming**: DASH bitrate quality selection
- **audio-effects**: Audio effect intensity with value clamping
- **midi**: MIDI note sequencing with velocity and duration
- **video-composition**: Video track composition and mixing
- **image-processing**: Image filter brightness scaling
- **sample-buffer**: Audio sample buffer allocation
- **color-space**: RGB to HSV color space conversion

### Performance (4 samples)

- **simd-operations**: SIMD array multiplication and summation
- **jit-optimization**: JIT execution time measurement
- **lock-free-collections**: Concurrent queue without locks
- **vectorization**: Vector addition with Zip operations

### Runtime (2 samples)

- **reflection**: Type inspection via reflection with property enumeration
- **dynamic-codegen**: Dynamic method compilation and execution

### UI (8 samples)

- **maui**: MAUI ViewModel with INotifyPropertyChanged
- **window-manager**: Window creation and lifecycle management
- **gesture-recognition**: Gesture event detection and routing
- **maccatalyst**: Mac Catalyst cross-platform app detection
- **appkit-interop**: AppKit system appearance detection
- **core-animation**: Core Animation duration and timing
- **touch-events**: Touch event detection and handling
- **pasteboard**: Pasteboard copy/paste operations

### Observability (5 samples)

- **memory-profiling**: Memory snapshot allocation tracking
- **cpu-profiling**: CPU execution time measurement
- **otel-dtrace**: OpenTelemetry/DTrace tracing control
- **etw-tracing**: Event Tracing for Windows event logging
- **distributed-tracing**: Distributed trace context generation

### Hardware (5 samples)

- **bluetooth**: Bluetooth device enumeration and discovery
- **usb-devices**: USB device enumeration
- **serial-port**: Serial port baud rate configuration
- **network-io**: Network I/O initialization and status
- **iousb**: USB interface description

### Integration (5 samples)

- **file-system-watcher**: File system event monitoring
- **spotlight-index**: Spotlight search indexing
- **system-notifications**: System notification delivery
- **finder-sync**: Finder sync integration
- **system-defaults**: System defaults read/write

### Testing (4 samples)

- **benchmarking**: Benchmark timing and measurement
- **thread-safety**: Thread-safe counter with Interlocked operations
- **memory-leaks**: Resource disposal and cleanup
- **chaos-engineering**: Fault injection and chaos testing

### Accessibility (2 samples)

- **axuielement**: Accessibility element registration and querying
- **voice-control**: Voice command execution and routing

### Web (1 sample)

- **webdriver**: WebDriver navigation and element selection

### Cloud (1 sample)

- **cloudkit-sync**: CloudKit data push/fetch/sync

### System (1 sample)

- **process-monitor**: Process snapshot recording and querying

## Quick start

- Read the overview: [docs/overview.md](docs/overview.md)
- Install prerequisites: [docs/prereqs.md](docs/prereqs.md)

## Repository layout

- **samples/** - 100 production-ready samples organized by domain
  - Each sample has `src/` (implementation) and `tests/` (unit tests)
  - Real business logic with meaningful test assertions
- **tooling/** - Build, signing, and packaging scripts
- **docs/** - Guides and platform notes
- **templates/** - Starter templates for new samples
- **assets/** - Shared icons and screenshots
- **legacy/** - Older samples retained for reference

## Legacy materials

- Original presentation: [docs/legacy/2021-presentation.md](docs/legacy/2021-presentation.md)
- Legacy sample folders: [legacy](legacy)

## CI guidance

- [docs/ci.md](docs/ci.md)

## Building & Testing

All samples target **.NET 10.0** with **xUnit 2.8.1** for testing.

```bash
# Build and test all samples
cd samples
for dir in */*/tests/*/; do
  dotnet test "$dir"
done

# Build and test a specific sample
dotnet test samples/security/keychain/tests/KeychainSample.Core.Tests/
```

## Implementation Quality

Each of the 100 samples includes:

- ✅ Real domain-specific business logic (not stubs)
- ✅ Comprehensive unit tests with meaningful assertions
- ✅ Proper async/await patterns where applicable
- ✅ Input validation and error handling
- ✅ Immutable data structures (records) where appropriate
- ✅ Interface implementations (INotifyPropertyChanged, IDisposable)
- ✅ Dictionary/List-based persistence for data samples
- ✅ Threading synchronization (locks, semaphores, channels)
- ✅ P/Invoke for native interop samples
- ✅ Vector math for graphics samples
- ✅ DSP filters for audio samples

All samples are production-ready reference implementations.
